// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const myCarouselElement = document.querySelector('#carouselIndicator')
const carousel = new bootstrap.Carousel(myCarouselElement, {
    interval: 2000,
    wrap: false
})