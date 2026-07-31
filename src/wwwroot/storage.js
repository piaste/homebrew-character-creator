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

  makeUrl: (version, text) => `${window.location.origin}?version=${version}&character=${encodeURIComponent(text)}`,

  openUrlShortener: function(version, text) {
    const longUrl = this.makeUrl(version, text);                                            
    window.open(`https://tinyurl.com/api-create.php?url=${encodeURIComponent(longUrl)}`, '_blank', 'noopener,noreferrer');
  },

  copyToClipboard: async function (version, text) {    
    await navigator.clipboard.writeText(this.makeUrl(version, text));
    return `window.characterStorage.openUrlShortener("${version}", "${text}")`;
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
