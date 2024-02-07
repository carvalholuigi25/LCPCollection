window.addEventListener("load", () => {
    if (document.getElementById("qrCode")) {
        new QRCode(document.getElementById("qrCode"),
        {
            text: document.getElementById("qrCodeData").getAttribute('data-url'),
            width: 128,
            height: 128,
            colorDark: "#000000",
            colorLight: "#ffffff",
            correctLevel: QRCode.CorrectLevel.H,
            logo: "/images/logos/logo.png",
            logoBackgroundTransparent: false
        });
    }
});