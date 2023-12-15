## v1.1 update:
![image](https://github.com/mastercodeon314/KeySpammer/assets/78676320/2f90547f-7c8b-4b19-8911-1bed09a616db)

# KeySpammer
A small winforms app to demonstrate what bad things can happen when KeyDown events are spammed in windows.

Demo Video:
https://i.imgur.com/sZ3MPUc.mp4
Please enable sound for the full experience.

Features:
- Spam volume up
- Spam volume down
- Spam mute key
- Spam control key
- Spam backspace key
- Spam delete key
- Spam ALT+F4 key combo
- Spam sleep key
- Spam SetDraw

Spamming SetDraw allows you to send a WM_SETREDRAW message to the desktop handle repeatedly/ This instructs the desktop to stop drawing things. Rendering the entire system usless. 
Spamming this message even disables the ability to get the desktop rendering again by CTRL+ALT+DEL or the SaS. 
Interesting sounds can results from spamming the mute key for 30ms or less. 
