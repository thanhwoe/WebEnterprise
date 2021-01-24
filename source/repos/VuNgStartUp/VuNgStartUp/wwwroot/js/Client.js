function hasUserMedia() {
    //check if the browser supports the WebRTC 
    return !!(navigator.getUserMedia || navigator.webkitGetUserMedia ||
        navigator.mozGetUserMedia);
}

if (hasUserMedia()) {
    navigator.getUserMedia = navigator.getUserMedia || navigator.webkitGetUserMedia
        || navigator.mozGetUserMedia;

    //enabling video and audio channels 
    navigator.mediaDevices.getUserMedia({ audio: false, video: true })
        .then(stream => {
            const video = document.getElementById('localstream');
            video.srcObject = stream;
            video.onloadedmetadata = function () {
                video.play()
            };
        })
}
else {
    alert("WebRTC is not supported");
}