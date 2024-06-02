@ModelType IEnumerable(Of BMS.Bus)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.BusNumber)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.BusModel)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Capacity)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.PurchaseDate)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Status)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.MaintenanceSchedule)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.BusNumber)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.BusModel)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Capacity)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.PurchaseDate)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Status)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.MaintenanceSchedule)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.BusID }) |
                @Html.ActionLink("Details", "Details", New With {.id = item.BusID }) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.BusID })
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
