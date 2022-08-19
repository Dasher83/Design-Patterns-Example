using Bridge.Models.Concrete;

/* 
For the sake of being practical, let's just asume we live in a world where 
a media device does not need to be turned on to change the channel or volume remotely
 */

Random random = new Random();
TV tv = new TV(channels: 60);
RemoteControl remote = new RemoteControl(tv);
remote.VolumeDown();
remote.TogglePower();
remote.VolumeUp();

Radio radio = new Radio();
AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(radio);
uint clicks = (uint)random.Next(1, 4);
while(clicks > 0)
{
    clicks--;
    advancedRemote.VolumeUp();
}
advancedRemote.Mute();
advancedRemote.Unmute();
advancedRemote.TogglePower();