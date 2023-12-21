import { Selector, t } from "testcafe";
import { SummaryBase } from "../SummaryBase";

class ManagerSummary extends SummaryBase {
    private Header: Selector;
    private DataGrid: Selector;

    constructor() {
        super();
        this.Header = Selector("#header_managers");
        this.DataGrid = Selector("#datagrid_managers");
    }

    public getHeaderSelector(): Selector {
        return this.Header;
    }

    public getDataGridSelector(): Selector {
        return this.DataGrid;
    }

    public getDataGridColumns(): string[] {
        throw ["Name", "Description", "Department"];
    }
}

export default new ManagerSummary();