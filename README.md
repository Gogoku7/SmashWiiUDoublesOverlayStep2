# SmashWiiUDoublesOverlayStep2
Step 2 of a project to create a dynamically editable overlay for Super Smash Bros. Wii U Doubles usable for any tournament streamer using HTML, CSS and C#.

Changes from Step 2:
- The manager solution/application has been added to the project, meaning you don't have to manually edit css files!

Anyone is allowed to clone this repository and create their own overlay manager if they feel it lacks some functionality that they need for their own tournament streams. I will not accept any pull requests unless it fixes an important bug.

I kept the code as simple and seperated in different functions as possible, to make it easier to understand for beginners in programming, anyone is allowed to clone this repository and refactor the code if they feel the code is too redundant. I will not accept any pull requests unless it fixes an important bug.

**Requirements:**
- Visual Studio 2017 (or higher) Community (or Professional/Enterprise).

**How to use:**
**How to use in Visual Studio:**
- Open SmashWiiUDoublesOverlayManager.sln using Visual Studio.
- Run the application.

![alt img](https://imgur.com/JxPkGZH.png)

- Fill the form on the overlay manager and click Submit.

![alt img](https://imgur.com/lzkitZe.png)

You can doublecheck whether the application works now by checking if all of the following files exist in "\SmashWiiUDoublesOverlayManager\SmashWiiUDoublesOverlayManager\bin\ {Debug/Release} \Files\css":
- team1NameText.css
- team1player1Character.css
- team1player1Port.css
- team1player2Character.css
- team1player2Port.css
- team1ScoreText.css
- team2NameText.css
- team2player1Character.css
- team2player1Port.css
- team2player2Character.css
- team2player2Port.css
- team2ScoreText.css
- roundBoxTest.css.
- tournamentBoxText.css.
- styles.css. (is there by default)

**How to use in Open Broadcaster Software (OBS Studio):**
- Add a new Browser source to your scene.

![alt img](https://imgur.com/tf1nFAP.png)

- Check the Local file checkbox and click Browse.

![alt img](https://imgur.com/czPD7Kl.png)
- Select gameOverlay.html in the "\SmashWiiUOverlayManager\SmashWiiUOverlayManager\bin\ {Debug/Release} \Files\css" folder. 
- Set the resolution and framerate. (1920 x 1080 at 60 frames per second recommended)
- Check Refresh browser when scene becomes active checkbox.

//

You are now ready to stream with the overlay.

As the streamed set(s) progress, you can update the overlay by filling in the inputs and clicking Submit in the overlay manager.

At this step, the overlay dynamically updates whenever the CSS is altered!
