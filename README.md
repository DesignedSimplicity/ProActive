![ProActive](https://raw.githubusercontent.com/DesignedSimplicity/ProActive/master/ProActive/Images/Logo.png)

**Simple GoPro file management application**

1. Loads all video files in a folder
1. Groups segmented videos in list view
1. Displays metadata for each video file
1. Edit seperate fields used to build name
1. Batch process all videos to new filename

The filename pattern has changed with the newest GoPro models which causes them to be displayed in an undesirable order in a file explorer making it difficult to view and rename segmented files.
This utility streamlines the process of grouping and renaming segmented video files.

#Before
![Loaded](https://raw.githubusercontent.com/DesignedSimplicity/ProActive/master/Screens/Files-Before.png)

#After
![Loaded](https://raw.githubusercontent.com/DesignedSimplicity/ProActive/master/Screens/Files-After.png)

#Instructions
## Launch Application
Run ProActive.exe
![Startup](https://raw.githubusercontent.com/DesignedSimplicity/ProActive/master/Screens/Main-Default.png)

## Load Videos
Click Path to select directory OR put path in textbox and hit Enter or click Load
This will populate the list with video files that match the GoPro Hero 7 naming convetion and automatically group them.
![Loaded](https://raw.githubusercontent.com/DesignedSimplicity/ProActive/master/Screens/Main-Loaded.png)

## Select Group
Select a video from the list and edit the Title, Date and Tags as desired.  These are autopopuated with default values parsed from the video file metadata.
Changes to the text fields are highlighed in yellow until they are saved in the cache, you must hit Enter in each textbox to save the changes before changing selection.
If GPS location data is embedded in the video the button will show the coordinates and clicking it will open your default browser to Google Maps at that position.
The video thumbnail preview can be changed by moving the slider at the bottom allowing you to select 1 minute increments from the first video segment.
![Loaded](https://raw.githubusercontent.com/DesignedSimplicity/ProActive/master/Screens/Main-Editing.png)

## Process Batch
Click Process Batch to open the dialog and confirm the changes that will be made.
If you do not want to process some of the video files, simple uncheck them before and they will be excluded.
![Loaded](https://raw.githubusercontent.com/DesignedSimplicity/ProActive/master/Screens/Process-Queued.png)

## Batch Completed
After clicking Process both the Batch screen and the main form will be refreshed showing you the result.
![Loaded](https://raw.githubusercontent.com/DesignedSimplicity/ProActive/master/Screens/Process-Completed.png)