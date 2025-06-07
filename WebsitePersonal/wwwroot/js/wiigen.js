class Wiigen extends HTMLElement {
    constructor() {
        super();
    } 
    connectedCallback() {
    const shadow = this.attachShadow({mode: "open"});
    
        const anchor = document.createElement("a");
        anchor.setAttribute("class", "badges")
        const l = document.createElement("div");
        l.textContent = "/>"

        anchor.appendChild(l);
        
        const r = document.createElement("div");
        r.textContent = "Wiigen";
        const style = document.createElement("style");
        anchor.appendChild(r);
        shadow.appendChild(anchor);
    }

}
customElements.define("wiigen-bagde", Wiigen);