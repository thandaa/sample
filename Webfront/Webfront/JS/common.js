

function JsonDateToFormat(theDate, format) {
    if (theDate == undefined || theDate == null) return "";
    var value = theDate;
    if (value.substring(0, 6) == "/Date(") {
        var dt = new Date(parseInt(value.substring(6, value.length - 2)));
        return formatDate(dt, format);
    }
    return "";
}




function NumberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

function GotoPage(LinkURL) {
    var w = window.location;
    var url = w.protocol + "//" + w.host + "/" + LinkURL;
    window.location.href = url;
}


function formatDate(date, format) {
    const options = {};
    if (format.includes("dd")) options.day = "2-digit";
    if (format.includes("mm")) options.month = "2-digit";
    if (format.includes("yy")) options.year = "numeric";

    return new Intl.DateTimeFormat('en-GB', options).format(date);
}

function GetURLData(param) {
    var url = new URL(window.location.href);
    return url.searchParams.get(param);
}
