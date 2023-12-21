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
        const active = this.getActiveSelector();
        const nameInput = this.getNameSelector();
        const description = this.getDescriptionSelector();
        const department = this.getDepartmentSelector();

        await t
            .expect(active.exists).ok()
            .expect(nameInput.exists).ok()
            .expect(description.exists).ok()
            .expect(department.exists).ok()
            .expect(this.manager.exists).ok();

        await t
            .typeText(nameInput, name)
            .typeText(department, generateString(8))
            .typeText(description, generateString(8))
            .click(active);

        await this.testHelpers.selectFromDropDown(t, this.manager, 0);
    }
}

export default new EmployeeDetail();