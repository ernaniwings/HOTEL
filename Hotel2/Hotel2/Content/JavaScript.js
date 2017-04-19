$(document).ready(function () {

    $("#0").click(function () {
        $.get($(this).id, )
        $.ajax({
            url: "Home/Search",
            type: "GET",
            dataType: "html",
            data: $(this).id,
            

        }).done(function (data) {
            alert(data)
        })

    })

    $("#span").click(function () {
        var div = document.createElement("div")
        div.className = "input-group"
        div.id = "inputgroup"
        $("#NewHotel").append(div)
        
        var input = document.createElement("input")
        input.id = "CadHotel"
        input.type = "text"
        input.placeholder = "Nome do hotel"
        input.className = "form-control"
        div.appendChild(input)
        var span = document.createElement("span")
        span.className = "input-group-btn"
        span.id = "spanbtn"
        div.appendChild(span)
        var button = document.createElement("button")
        button.className = "btn btn-default"
        button.type = "button"
        button.innerHTML = "Go"
        span.appendChild(button)
            
            
        

        $(this).remove();
        
        

    })

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