$(document).ready(function () {

    

    $("#First").click(function () {
        if ($("#collapseDown").css("display") === "none") {
            $(".HotelTab").animate({
                opacity: "toggle",
                top: "+=50",
                height: "toggle"
            }, 300, function () {
                $("#collapseDown").show()
                $("#collapseUp").hide()
            })
        } else {
            $(".HotelTab").animate({
                opacity: "toggle",
                top: "+=50",
                height: "toggle"
            }, 300, function () {
                $("#collapseDown").hide()
                $("#collapseUp").show()
            })
        }
        

    })

})