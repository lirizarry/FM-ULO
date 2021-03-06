﻿$(document).ready(function () { 
    setValid();
    setReason();
    showHideFiltersInit();
    $("#clearFilters").click(function () {
        $("#uloId").val("");
        $("#pegasysDocumentNumber").val("");
        $("#organization").val("");
        $("#region").val("");
        $("#zone").val("");
        $("#fund").val("");
        $("#baCode").val("");
        $("#docType").val("");
        $("#pegasysTitleNumber").val("");
        $("#pegasysVendorName").val("");
        $("#contractingOfficersName").val("");
        $("#currentlyAssignedTo").val("");
        $("#awardNumber").val("");
        $("#reasonIncludedInReview").val("");
        $("#valid").val("");
        $("#status").val("");
        $("#reviewId").val("");
        $("#hasBeenAssignedto").val("");
    });

    $("#showFilters").click(function() {
        $("#filterRegions").toggle();
        if ($("#filterRegions").is(":visible")) {
            $(this).html("Hide Filters");
        } else {
            $(this).html("Show Filters");
        }
    });
});



function filter(pdn, org, region, zone, fund, baCode, docType, ptn, pvn, contractingOfficersName, awardNumber, reasonIncludedInReview, valid, reviewedBy, status) {
    var url = "/Ulo/Search?";
    url += "pegasysDocumentNumber=" + (pdn ? pdn : "");
    url += "&organization=" + (org ? org : "");
    url += "&region=" + (region ? region : "");
    url += "&zone=" + (zone ? zone : "");
    url += "&fund=" + (fund ? fund : "");
    url += "&baCode=" + (baCode ? baCode : "");
    url += "&docType=" + (docType ? docType : "");
    url += "&pegasysTitleNumber=" + (ptn ? ptn : "");
    url += "&pegasysVendorName=" + (pvn ? pvn : "");
    url += "&contractingOfficersName=" + (contractingOfficersName ? contractingOfficersName : "");
    url += "&awardNumber=" + (awardNumber ? awardNumber : "");
    url += "&reasonIncludedInReview=" + (reasonIncludedInReview ? reasonIncludedInReview : "");
    url += "&valid=" + (valid ? valid : "");
    url += "&status=" + (status ? status : "");
    $("#masterRecordsListing").load(url);
}

function showHideFiltersInit() {
    if ($("#uloId").val() != "" ||
        $("#pegasysDocumentNumber").val() != "" ||
        $("#organization").val() !="" ||
        $("#region").val() !="" ||
        $("#zone").val() !="" ||
        $("#fund").val() !="" ||
        $("#baCode").val() !="" ||
        $("#docType").val() !="" ||
        $("#pegasysTitleNumber").val() !="" ||
        $("#pegasysVendorName").val() !="" ||
        $("#contractingOfficersName").val() != "" ||
        $("#currentlyAssignedTo").val() != "" ||
        $("#awardNumber").val() !="" ||
        $("#reasonIncludedInReview").val() !="" ||
        $("#valid").val() !="" ||
        $("#status").val() != "" || 
        $("#reviewId").val() != ""
        || $("#hasBeenAssignedto").val() != "") {
            $("#filterRegions").show();
            $("#showFilters").html("Hide Filters");
    }
    else {
        $("#filterRegions").hide();
        $("#showFilters").html("Show Filters");
    }
}

function setValid() {
    var valid = getParameterByName("valid");
    if (valid != "") {
        $("#valid").val(valid);
    }
}

function setReason() {
    var reasonIncludedInReview = getParameterByName("reasonIncludedInReview");
    if (reasonIncludedInReview != "") {
        $("#reasonIncludedInReview").val(reasonIncludedInReview);
    }
}
function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return "";
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}