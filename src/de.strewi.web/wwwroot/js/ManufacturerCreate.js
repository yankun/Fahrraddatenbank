(function () {
	$(document).ready(function () {
		$('#OvertakenById').typeahead({
			source: ['Weil-Werke', 'Welt-Rad', 'Welt-Flieger', 'Westerheide'],
			fitToElement: true
		});
	})
})();