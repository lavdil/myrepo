﻿@ModelType BMS.Bus

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <div>
        <h4>Bus</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.BusNumber)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.BusNumber)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.BusModel)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.BusModel)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Capacity)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Capacity)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.PurchaseDate)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.PurchaseDate)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Status)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Status)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.MaintenanceSchedule)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.MaintenanceSchedule)
            </dd>
    
        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With { .id = Model.BusID }) |
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>
