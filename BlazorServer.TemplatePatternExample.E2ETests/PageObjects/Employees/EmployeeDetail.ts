import { Selector, t } from "testcafe";
import { DetailBase } from "../../PageObjects/DetailBase";
import { generateString } from "../../Utilities";
import { TestHelpers } from "../../TestHelpers/TestHelpers";

export class EmployeeDetail extends DetailBase {
    private header: Selector;
    private manager: Selector;
    private testHelpers: TestHelpers;

    constructor() {
        super();
        this.header = Selector("#header_newemployee");
        this.manager = Selector("#select_managers");
        this.testHelpers = new TestHelpers();
    }

    public getHeaderSelector(): Selector {
        return this.header;
    }

    public async populateForm(t: TestController, name: string): Promise<void> {
        await t.expect(this.manager.exists).ok();
        await this.testHelpers.selectFromDropDown(t, this.manager, 0);
        super.populateForm(t, name);
    }
}

export default new EmployeeDetail();