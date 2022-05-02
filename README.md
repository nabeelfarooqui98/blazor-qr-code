# QR Code Generator With Blazor UI
Blazor WASM app to generate QR codes


Used Blazor WASM .Net Core Hosted because I wansted to use QRCoder to generate the QR code. However it was using System.Drwaing which is not supported in WASM on client side so I had to do the creation on the .Net server. 
https://www.reddit.com/r/dotnet/comments/jzxzse/blazor_wasm_cannot_use_bitmap_or/ 

![image](https://user-images.githubusercontent.com/25402598/166172188-f4308a43-959a-4925-a38a-151ac5ddc971.png)
