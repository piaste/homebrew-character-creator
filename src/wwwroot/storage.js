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
  copyToClipboard: async function (text) {
    await navigator.clipboard.writeText(text);
  }
};

windows.uiHelpers = {
  scrollIntoView: function(elementId) {
    document.getElementById(elementId).scrollIntoView({
        behavior: "smooth",
        inline: "center",
        block: "nearest"
    })
  }
}