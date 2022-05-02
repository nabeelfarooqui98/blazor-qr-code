# QR Code Generator With Blazor UI
Blazor WASM app to generate QR codes


Used Blazor WASM .Net Core Hosted because I wansted to use QRCoder to generate the QR code. However it was using System.Drwaing which is not supported in WASM on client side so I had to do the creation on the .Net server. 
https://www.reddit.com/r/dotnet/comments/jzxzse/blazor_wasm_cannot_use_bitmap_or/ 
