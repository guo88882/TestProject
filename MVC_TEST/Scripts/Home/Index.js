vmStart();
var vm;
function vmStart() {
    vm = new Vue({
        el: '#Index',
        data: {
           TestStr:"我在測試",
        },
        mounted: function () {
            this.$nextTick(function () {
              
            });
        },
        methods: {
         
        }
    })
}