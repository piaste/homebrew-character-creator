window.characterStorage = {
  load: function (key) {
    return window.localStorage.getItem(key);
  },
  save: function (key, value) {
    window.localStorage.setItem(key, value);
  },
  clear: function (key) {
    window.localStorage.removeItem(key);
  },
  copyToClipboard: async function (version, text) {
    let linkUrl = `${window.location.origin}?version=${version}&character=${encodeURIComponent(text)}`
    await navigator.clipboard.writeText(linkUrl);
  },
  pasteFromClipboard: async function () {
    return await navigator.clipboard.readText();
  }
};

window.uiHelpers = {
  scrollIntoView: function(elementId) {
    document.getElementById(elementId).scrollIntoView({
        behavior: "smooth",
        inline: "center",
        block: "nearest"
    })
  }
}