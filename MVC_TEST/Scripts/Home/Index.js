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
                vm.GetTestAPI();
            });
        },
        methods: {
            GetTestAPI: function () {
                $.ajax({
                    url:  "../swagger/api/Test/TestGet?type=AA",
                    type: "GET",
                    dataType: "json",
                    success: function (datas) {
                        console.log(datas)
                    }
                });
            },
        }
    })
}