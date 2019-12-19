/* Carousel javascript https://www.w3schools.com/howto/howto_js_slideshow.asp */
/*LAGKAGER*/
let slideIndex = 1;
visSlides(slideIndex);

function skiftSlides(n) {
  visSlides((slideIndex += n));
}

function aktuelSlide(n) {
  visSlides((slideIndex = n));
}

function visSlides(n) {
  let i;
  let slides = document.getElementsByClassName("slides");
  let slideKnap = document.getElementsByClassName("slideknap");
  if (n > slides.length) {
    slideIndex = 1;
  }
  if (n < 1) {
    slideIndex = slides.length;
  }
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  for (i = 0; i < slideKnap.length; i++) {
    slideKnap[i].className = slideKnap[i].className.replace(" valgt", "");
  }
  slides[slideIndex - 1].style.display = "block";
  slideKnap[slideIndex - 1].className += " valgt";
}

/* CAROUSEL JAVASCRIPT KAGEMAND*/
let slideIndex2 = 1;
visSlides2(slideIndex2);

function skiftSlides2(n) {
  visSlides2((slideIndex2 += n));
}

function aktuelSlide2(n) {
  visSlides2((slideIndex2 = n));
}

function visSlides2(n) {
  let i;
  let slides2 = document.getElementsByClassName("slidesKagemand");
  let slideKnap = document.getElementsByClassName("slideknap2");
  if (n > slides2.length) {
    slideIndex2 = 1;
  }
  if (n < 1) {
    slideIndex2 = slides2.length;
  }
  for (i = 0; i < slides2.length; i++) {
    slides2[i].style.display = "none";
  }
  for (i = 0; i < slideKnap.length; i++) {
    slideKnap[i].className = slideKnap[i].className.replace(" valgt", "");
  }
  slides2[slideIndex2 - 1].style.display = "block";
  slideKnap[slideIndex2 - 1].className += " valgt";
}

/* CAROUSEL JAVASCRIPT BRYLLUPSKAGER*/
let slideIndex3 = 1;
visSlides3(slideIndex3);

function skiftSlides3(n) {
  visSlides3((slideIndex3 += n));
}

function aktuelSlide3(n) {
  visSlides3((slideIndex3 = n));
}

function visSlides3(n) {
  let i;
  let slides3 = document.getElementsByClassName("slidesBryllupskage");
  let slideKnap = document.getElementsByClassName("slideknap3");
  if (n > slides3.length) {
    slideIndex3 = 1;
  }
  if (n < 1) {
    slideIndex3 = slides3.length;
  }
  for (i = 0; i < slides3.length; i++) {
    slides3[i].style.display = "none";
  }
  for (i = 0; i < slideKnap.length; i++) {
    slideKnap[i].className = slideKnap[i].className.replace(" valgt", "");
  }
  slides3[slideIndex3 - 1].style.display = "block";
  slideKnap[slideIndex3 - 1].className += " valgt";
}

/* CAROUSEL JAVASCRIPT KRANSEKAGE*/
let slideIndex4 = 1;
visSlides4(slideIndex4);

function skiftSlides4(n) {
  visSlides4((slideIndex4 += n));
}

function aktuelSlide4(n) {
  visSlides4((slideIndex4 = n));
}

function visSlides4(n) {
  let i;
  let slides4 = document.getElementsByClassName("slidesKransekage");
  let slideKnap = document.getElementsByClassName("slideknap4");
  if (n > slides4.length) {
    slideIndex4 = 1;
  }
  if (n < 1) {
    slideIndex4 = slides4.length;
  }
  for (i = 0; i < slides4.length; i++) {
    slides4[i].style.display = "none";
  }
  for (i = 0; i < slideKnap.length; i++) {
    slideKnap[i].className = slideKnap[i].className.replace(" valgt", "");
  }
  slides4[slideIndex4 - 1].style.display = "block";
  slideKnap[slideIndex4 - 1].className += " valgt";
}
