$(function(){
	
	/* Morris Area Chart */
	
	window.mA = Morris.Area({
		parseTime: false,
	    element: 'morrisArea',
	    data: [
	        { y: '1395', a: 60},
	        { y: '1396', a: 100},
	        { y: '1397', a: 240},
	        { y: '1398', a: 120},
	        { y: '1399', a: 80},
	        { y: '1400', a: 100},
	        { y: '1402', a: 300},
	    ],
	    xkey: 'y',
	    ykeys: ['a'],
	    labels: ['درآمد'],
	    lineColors: ['#1b5a90'],
	    lineWidth: 2,
		
     	fillOpacity: 0.5,
	    gridTextSize: 10,
	    hideHover: 'auto',
	    resize: true,
		redraw: true
	});
	
	/* Morris Line Chart */
	
	window.mL = Morris.Line({
		parseTime: false,
	    element: 'morrisLine',
	    data: [
	        { y: '1395', a: 100, b: 30},
	        { y: '1396', a: 20,  b: 60},
	        { y: '1397', a: 90,  b: 120},
	        { y: '1398', a: 50,  b: 80},
	        { y: '1399', a: 120,  b: 150},
	    ],
	    xkey: 'y',
	    ykeys: ['a', 'b'],
	    labels: ['مدرسان', 'دانش آموزان'],
	    lineColors: ['#1b5a90','#ff9d00'],
	    lineWidth: 1,
	    gridTextSize: 10,
	    hideHover: 'auto',
	    resize: true,
		redraw: true
	});
	$(window).on("resize", function(){
		mA.redraw();
		mL.redraw();
	});

});