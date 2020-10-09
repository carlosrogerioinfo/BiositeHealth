
/*
 Template Name: Lexa - Responsive Bootstrap 4 Admin Dashboard
 Author: Themesbrand
 File: Dashboard init js
 */

!function ($) {
    "use strict";

    var Dashboard = function () { };

    //creates area chart
    Dashboard.prototype.createAreaChart = function (element, pointSize, lineWidth, data, xkey, ykeys, labels, lineColors) {
        Morris.Area({
            element: element,
            pointSize: 0,
            lineWidth: 1,
            data: data,
            xkey: xkey,
            ykeys: ykeys,
            labels: labels,
            resize: true,
            gridLineColor: '#eee',
            hideHover: 'auto',
            lineColors: lineColors,
            fillOpacity: .9,
            behaveLikeLine: true
        });
    },

        //creates Donut chart
        Dashboard.prototype.createDonutChart = function (element, data, colors) {
            Morris.Donut({
                element: element,
                data: data,
                resize: true,
                colors: colors
            });
        },

        Dashboard.prototype.init = function () {

            //creating area chart
            var $areaData = [
                {y: '2011', a: 10},
                {y: '2012', a: 10},
                {y: '2013', a: 2},
                { y: '2017', a: 15 },
                { y: '2018', a: 10 },
                { y: '2019', a: 5 },
                { y: '2020', a: 2 }
            ];

            this.createAreaChart('morris-area-example', 0, 0, $areaData, 'y', ['a'], ['Exames Analisados'], ['#7a6fbe']);


            //creating donut chart
            var $donutData = [
                { label: "Resultado", value: 0.03 }
            ];
            this.createDonutChart('morris-donut-example', $donutData, ['#20c997']);

            //creating donut chart
            var $donutData = [
                { label: "Resultado", value: 21 }
            ];
            this.createDonutChart('morris-donut-example2', $donutData, ['#fd7e14']);

            var $donutData = [
                { label: "Resultado", value: 8.8 }
            ];
            this.createDonutChart('morris-donut-example3', $donutData, ['#dc3545']);

            var $donutData = [
                { label: "Resultado", value: 7 }
            ];
            this.createDonutChart('morris-donut-example4', $donutData, ['#20c997']);

        },
        //init
        $.Dashboard = new Dashboard, $.Dashboard.Constructor = Dashboard
}(window.jQuery),

    //initializing 
    function ($) {
        "use strict";
        $.Dashboard.init();
    }(window.jQuery);