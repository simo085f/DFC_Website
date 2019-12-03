"use strict";
let width = window.matchMedia("(max-width: 768px)");
ScrollFunction(width);
width.addListener(ScrollFunction);
ScrollReveal().reveal(".borderTxtContainer", {
  viewFactor: 1.0,
  delay: 100,
  easing: "ease-in"
});

ScrollReveal().reveal(".kagensDagContainer", {
  viewFactor: 0.8,
  delay: 100,
  easing: "ease-in"
});

function ScrollFunction() {
  if (width.matches) {
    ScrollReveal().reveal(
      ".produkt1Container, .produkt2Container, .produkt3Container, .produkt4Container",
      {
        viewFactor: 1.0,
        delay: 200,
        easing: "ease-in"
      }
    );
  } else {
    ScrollReveal().reveal(
      ".produkt1Container, .produkt2Container, .produkt3Container, .produkt4Container",
      {
        viewFactor: 0.8,
        delay: 200,
        easing: "ease-in"
      }
    );
  }
}

ScrollReveal().reveal(".kontaktTxtContainer", {
  viewFactor: 0.8,
  delay: 200,
  easing: "ease-in"
});

ScrollReveal().reveal(".aarstal", {
  viewFactor: 0.8,
  delay: 200,
  easing: "ease-in"
});

ScrollReveal().reveal(".aarstalDesktop", {
  viewFactor: 0.6,
  delay: 200,
  easing: "ease-in"
});
