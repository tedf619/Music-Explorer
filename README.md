# Music Explorer - A Simple C# .Net App with Windows Forms

Windows Forms has been supported by Microsoft since the very first version of the .Net Framework. WinForms continued to evolve until 2019, when Microsoft released the last .Net Framework version (4.8) before switching to the multi-platform .Net Core architecture. The first versions of .Net Core had no support for Windows Forms. Due to pressure from the development community, Microsoft eventually caved in. It took several years for Windows Forms to reach maturity in .Net Core but Visual Studio eventually gained a Forms Designer equivalent to what was available in the old .Net Framework.
To illustrate the power of Windows Forms to people that might be new to the technology, I’ll describe a simple but full-fledged desktop application called Music Explorer. The following figure shows the app in action. 

<img width="789" height="527" alt="image" src="https://github.com/user-attachments/assets/ce344c9e-5149-4af6-85c0-241538a6e407"/>

*Figure 1 - The Music Explorer interface.*

The app lets you lookup recording artists and their albums. For each album it shows the tracks included and the lyrics for each track. A handful of free web services are used to get the actual data.

## How it works

There are three main user actions:
  1.	Searching for an artist. The MusicBrainz web service is called to get a list of albums.
  2.	Selecting an album. The MusicBrainz web service is called to get the album details. The CoverArtArchive service is also called to get the cover art image.
  3.	Selecting a song. The LrcLib service is called to get the song lyrics.

The following sequence diagram shows the details.

<img width="720" height="531" alt="image" src="https://github.com/user-attachments/assets/8e271aab-ee98-4cdc-b63b-15287364c189" />

*Figure 2 - The main operations of the app.*

Since the three web services have a lot in common, that functionality was migrated to a base class as shown in the next figure.
 
<img width="649" height="278" alt="image" src="https://github.com/user-attachments/assets/0f2764fb-9e35-4762-aa48-d683587e875b" />

*Figure 3 - The class hierarchy of web services.*

## The UI Layout

The app is hosted in a single form subdivided into three layers. Each layer used docked panels to achieve the desired layout. See the following figure.

<img width="891" height="597" alt="image" src="https://github.com/user-attachments/assets/ddc5dcfb-2ccf-473f-a1c4-179a3650811b" />

*Figure 4 - The three layers of panels used for the UI.*

  *	Layer 1: Shown in blue, holds a top, middle and bottom panel. The top panel holds the Search Bar, the bottom panel holds the Status Bar and the middle panel holds the gist of the application.
  *	Layer 2: Shown in red, subdivides the middle panel into three parts. The left panel holds the Album List, the middle panel holds the Album Details, the right panel holds the HTTP Log.
  *	Layer 3: Shown in gray, further subdivides the middle red panel into areas for the Album Details, the Track List and the Lyrics.

## Persisting Data

Applications sometimes save user data for subsequent runs. In the case of Music Explorer, we save the name of the last Artist entered. When starting up, we load the name so the user doesn’t have to reenter it.
To persist user fields, the easiest way is to use the app’s settings. In Visual Studio, I created a simple string setting called Artist, as shown in the following figure.

<img width="828" height="316" alt="image" src="https://github.com/user-attachments/assets/af2d0727-3f68-4879-8646-99e53fcfed95" />

*Figure 5 – Creating a user setting in Visual Studio.*

User settings are stored in the file user.config:

```xml
<configuration>
    <userSettings>
        <MusicExplorer.Properties.Settings>
            <setting name="Artist" serializeAs="String">
                <value>Led Zeppelin</value>
            </setting>
        </MusicExplorer.Properties.Settings>
    </userSettings>
</configuration>
```
*Listing 1- The config file containing user settings.*

As the filename indicates, the settings in this file are user-specific, and stored in a folder named: 

`C:\Users\<User>\AppData\Local\<Company Name>\<App Name>_Url_<Random Characters>\<App Version>`

For Music Explorer, the folder is:

`C:\Users\Ted\AppData\Local\MusicExplorer\MusicExplorer_Url_c1wj4u3w4mo1mp4pcrhoig00k3rq1rhs\1.0.0.0`

We load the Artist settings during initialization with the code:

```csharp
public FormMain()
{
  InitializeComponent();
  // ...

  textBoxArtist.Text = Properties.Settings.Default.Artist;
}
```
*Listing 2- Loading settings at startup time.*

Saving updated settings is just as easy:

```csharp
  Properties.Settings.Default.Artist = textBoxArtist.Text;
  Properties.Settings.Default.Save();
```
*Listing 3- Saving user settings.*

## Showing HTTP Traffic

Http traffic is handled mainly by the MusicBrainz web service. Since FormMain calls MusicBrainz to send/receive data, we can’t have the web service call FormMain back to display HTTP traffic. Doing so would introduce circular coupling and the application wouldn’t build properly. The simple solution is to have the web service fire events to notify FormMain with traffic data. The WebService base class of MusicBrainz is equipped with three events as shown in the next figure:

<img width="402" height="101" alt="image" src="https://github.com/user-attachments/assets/26b22f1e-6a85-41fe-bb4d-1294ebf40b00" />

*Figure 6 – The events exposed by the web services.*

FormMain handles these events by updating the user interface as appropriate. When exceptions occur, they are shown in red text in the HTTP Log. Ordinary messages are shown in black. The ProgressChanged event is fired during the relatively lengthy process of retrieving an artist’s list of albums. The event handler updates the progress bar shown on the right side of the status bar while getting data.
Something to be aware of is that Music Explorer occasionally shows HTTP 503 (Service Temporarily Unavailable) errors in the log. These are triggered by the MusicBrainz service in order to throttle incoming requests. Since these errors are expected, the MusicBrainz web service pauses after failed requests and then automatically retries a few times. The following figure shows a log with an error.

<img width="796" height="498" alt="image" src="https://github.com/user-attachments/assets/bf961364-e028-460a-b383-3219b5bd1115" />

*Figure 7 – The HTTP Log showing a communication error in red.*

## Conclusion

As I’ve hopefully demonstrated with Music Explorer, Windows Forms is a powerful tool for developing desktop applications with .Net. The extensive use of docked panels makes quick work of complicated user interfaces. The Forms Designer, with its drag and drop support, allows you to instantly see the results of your actions without needing to rebuild your project after every change. If Windows Forms has been around for over 25 years, the Forms Designer is a major reason.








