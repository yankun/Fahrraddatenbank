(function () {
	$(document).ready(function () {
		$('#search-box').typeahead({
			source: ['Weil-Werke', 'Welt-Rad', 'Welt-Flieger', 'Westerheide'],
			fitToElement: true
		});
	})
})();