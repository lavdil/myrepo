@ModelType BMS.Bus

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
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
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
    
            @<div class="form-actions no-color">
                <input type="submit" value="Delete" class="btn btn-default" /> |
                @Html.ActionLink("Back to List", "Index")
            </div>
        End Using
    </div>
</body>
</html>
