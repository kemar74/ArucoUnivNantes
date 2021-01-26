# ArucoUnivNantes
## Immersive data visualization using AruCo
Authors: AL ANAISSY Caren and LOMBAERDE Julien and HARTLEY Marc

## Installation
This project has been made on [Unity](https://unity.com/), please be sure to have Unity installed.  

To start working on the project:
```console
git clone https://github.com/kemar74/ArucoUnivNantes.git
```

## The use of ArucoUnity
This project relies on [ArucoUnity](https://github.com/NormandErwan/ArucoUnity) by [@NormandErwan](https://github.com/NormandErwan/).  

You can check if the package is activated by checking if the tab "Aruco Unity" is displayed on top of the Unity editor:
![AruCo Unity tab](https://raw.githubusercontent.com/kemar74/arucoUnivNantes/main/readmeImgs/check_for_package.PNG)

If it's not, try to import the package "ArucoUnity.unitypackage" that you can find at the root of the repository.  
For this, 
- open the project on Unity,
- double-click on the file "ArucoUnity.unitypackage" from the Windows explorer/Finder/Whatever,
- back to Unity, a window should open. Click on "Import all"


## From PC to your Android phone/tablet
This app should be available for smartphones and tablets. In our case, we will only look for Android OS as we all have this kind of devices.  
First, you need to download the Unity module to tranform a project into a .apk file :
- Open Unity Hub on your computer,
- Go to the "Install" tab (1)
- Open the menu (2) and select "Add modules"  
![Unity Hub Install](https://raw.githubusercontent.com/kemar74/arucoUnivNantes/main/readmeImgs/Unity_Hub_Install_1.PNG)
- Select the "Android Build Support" and click one "Done". (This will download about 4GB through your wifi, please be sure to have internet access and enough storage on your disk)  
![Unity Hub Install, selecting "Android Build Support"](https://raw.githubusercontent.com/kemar74/arucoUnivNantes/main/readmeImgs/Unity_Hub_Install_2.PNG)
- When the download is complete (might take sevral minutes to an hour depending on your internet connection), reload your Unity project.
- In the top menu, go to "File" > "Build settings..." and select "Android"  
![Build settings window](https://raw.githubusercontent.com/kemar74/arucoUnivNantes/main/readmeImgs/build_settings.PNG)
- If all went well, you should see a page like this. If the page displayes something like "No Android module installed", please retry from step 1.
- You can change different settings as the app name, company etc by clicking the "Player Settings..." button and you will see the parameters in the inspector of the Unity Editor. When you're ready, press "Switch Platform".
- After some processing, the "Switch Platform" button should have become "Build".
- Connect your phone to the computer with a USB cable.
- Press "Build" and save the .apk on your smartphone (This will, once again, take a while)
- From your smartphone, access to your files and navigate the location where you saved the .apk. Select it and execute it (press "Install"). It will maybe tell you that it's an app coming from an "unknown source", so allow your OS to install "unknown source" (sometimes in "Parameters" > "Security" > "Unknown source"). If your phone tells you "Blocked by Play Protect", press on "Install anyway".
- The app must now be available in "All apps" with a logo of Unity if you didn't changed it in the "Player settings"

- For the developping phase, consider installing a emulator on your computer. An free and efficient emulator is [BlueStacks](https://www.bluestacks.com/fr/index.html)
- Download BlueStacks and launch it.
- To try our application, save the .apk in your PC instead of your phone.
- Click on "Install APK" and find your .apk file  
![Capture of BlueStacks](https://raw.githubusercontent.com/kemar74/arucoUnivNantes/main/readmeImgs/BlueStacks_1.PNG)
- You should find your application in "Library" (1)  
![Capture of BlueStacks](https://raw.githubusercontent.com/kemar74/arucoUnivNantes/main/readmeImgs/BlueStacks_2.PNG)