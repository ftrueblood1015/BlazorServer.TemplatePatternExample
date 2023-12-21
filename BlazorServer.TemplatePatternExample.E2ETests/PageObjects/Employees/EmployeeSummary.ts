import { Selector, t } from "testcafe";
import { SummaryBase } from "../SummaryBase";

class EmployeeSummary extends SummaryBase {
    private Header: Selector;
    private DataGrid: Selector;

    constructor() {
        super();
        this.Header = Selector("#header_employees");
        this.DataGrid = Selector("#datagrid_employees");
    }

    public getHeaderSelector(): Selector {
        return this.Header;
    }

    public getDataGridSelector(): Selector {
        return this.DataGrid;
    }

    public getDataGridColumns(): string[] {
        throw ["Name", "Description", "Department", "Manager"]
    }
}

export default new EmployeeSummary();