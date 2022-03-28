// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('.add').click(function () {
	if ($(this).prev().val() < 10) {
		$(this).prev().val(+$(this).prev().val() + 1);
	}
});
$('.sub').click(function () {
	if ($(this).next().val() > 1) {
		if ($(this).next().val() > 1) $(this).next().val(+$(this).next().val() - 1);
	}
});
