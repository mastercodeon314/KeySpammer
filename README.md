# KeySpammer
A small winforms app to demonstrate what bad things can happen when KeyDown events are spammed in windows.

Demo video:
<video src='https://github.com/mastercodeon314/KeySpammer/assets/78676320/8c09143a-95e4-4a05-b6ce-c710b1b011bc' width=180/>

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
