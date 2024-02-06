function BlazorSetClassAct(id) {
    const element = document.getElementById(id);
    if (element instanceof HTMLElement) {
        if (document.querySelectorAll('#navapidocslinks').length > 0) {
            for (var i = 0; i < document.querySelectorAll('#navapidocslinks .mud-nav-link').length; i++) {
                if (document.querySelectorAll('#navapidocslinks .mud-nav-link')[i].classList.contains("active")) {
                    document.querySelectorAll('#navapidocslinks .mud-nav-link')[i].classList.remove("active");
                }
            }

            document.querySelectorAll(`#navapidocslinks .mud-nav-link[href='docs/api#${id}']`)[0].classList.add("active");
        }
    }
}

function BlazorScrollToId(id) {
    const element = document.getElementById(id);
    if (element instanceof HTMLElement) {
        element.scrollIntoView({
            behavior: "smooth",
            block: "start",
            inline: "nearest"
        });
    }
}

function loadPlayer(id, options) {
    if(document.getElementById(id)) {
        let player;
        let players = videojs.players;
        if(players && Object.keys(players).length) {
            player = players[id];
            player.dispose();
        }
        player = videojs(id, options);
    }
}

window.addEventListener("DOMContentLoaded", () => {
    console.log("Loaded app.js!");
});