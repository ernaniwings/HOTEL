$(document).ready(function () {
    $("span[name='Products']").click(function () {
        $("div#teste > div").remove();
        $.post("getProducts", function (data) {


            $("#teste").append(data);

        });

    });
    $("span[name='Clients']").click(function () {
        $("div#teste > div").remove();
        $.post("getClients", function (data) {


            $("#teste").append(data);

        });

    })
    $("span[name|='hotel']").click(function () {

        $("div#teste > div").remove();
        $.post("Search/" + $(this).attr("id"), function (data) {


            $("#teste").append(data);

        });
        

    });

    function create() {
        var url = "CreateHotel/" + $("#CadHotel").val();
        
        $.ajax({
            url: url,
            type: "POST",
            data: $("#CadHotel")
        }).done(function (data) {
            //alert(data)
        })
        $("#ulSideBar").load(location.href + " #ulSideBar");
        $("#HotelTab li:last-child").fadeOut(100, function () {
            $(this).fadeIn();
            $(this).animate({ "border-color": "#add8e6" }, 500, function (element) {
                element.animate({ "border-color": "black" }, 500)
                })
        });
                
    };
    
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
        var button = document.createElement("input")
        button.className = "btn btn-default"
        button.type = "submit"
        button.value = "go"
        button.onclick = create
        button.id = "go"
        span.appendChild(button)
            
            
        

        $(this).remove();
        var anotherli = document.createElement("li")
        anotherli.append($(this))
        $("#HotelTab").append(anotherli)
        

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