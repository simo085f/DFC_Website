"use strict";
/* media queries til scrollreveal - reference: https://www.w3schools.com/howto/howto_js_media_queries.asp 
scroll reveal - referance: https://scrollrevealjs.org/api/reveal.html */
let width = window.matchMedia("(max-width: 768px)");
ScrollFunction(width);
width.addListener(ScrollFunction);
function ScrollFunction() {
  if (width.matches) {
    ScrollReveal().reveal(".borderTxtContainer", {
      viewFactor: 1.0,
      delay: 100,
      easing: "ease-in"
    });

    ScrollReveal().reveal(".kagensDagContainer", {
      viewFactor: 0.4,
      delay: 200,
      easing: "ease-in"
    });

    ScrollReveal().reveal(
      ".produkt1Container, .produkt2Container, .produkt3Container, .produkt4Container",
      {
        viewFactor: 1.0,
        delay: 200,
        easing: "ease-in"
      }
    );
    ScrollReveal().reveal(".kontaktTxtContainer", {
      viewFactor: 0.6,
      delay: 200,
      easing: "ease-in"
    });
  } else {
    ScrollReveal().reveal(".borderTxtContainer", {
      viewFactor: 0.5,
      delay: 150,
      easing: "ease-in"
    });

    ScrollReveal().reveal(
      ".produkt1Container, .produkt2Container, .produkt3Container, .produkt4Container",
      {
        viewFactor: 0.5,
        delay: 150,
        easing: "ease-in"
      }
    );
    ScrollReveal().reveal(".kagensDagContainer", {
      viewFactor: 0.5,
      delay: 200,
      easing: "ease-in"
    });
    ScrollReveal().reveal(".kontaktTxtContainer", {
      viewFactor: 0.5,
      delay: 200,
      easing: "ease-in"
    });
  }
}

ScrollReveal().reveal(".aarstal", {
  viewFactor: 0.2,
  easing: "ease-in"
});

ScrollReveal().reveal(".aarstalDesktop", {
  viewFactor: 0.3,
  delay: 100,
  easing: "ease-in"
});
