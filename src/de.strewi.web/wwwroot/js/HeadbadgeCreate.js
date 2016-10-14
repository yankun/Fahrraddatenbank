(function () {
	$(document).ready(function () {
		$('#ManufacturerId').typeahead({
			source: ['Weil-Werke', 'Welt-Rad', 'Welt-Flieger', 'Westerheide'],
			fitToElement: true
		});
	})
})();