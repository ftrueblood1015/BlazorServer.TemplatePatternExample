import { TestHelpers } from "./TestHelpers";
import { DetailBase } from "../PageObjects/DetailBase";
import { generateString } from "../Utilities";

export class DetailBaseTests {
    private detailPageObjectModel: DetailBase;

    constructor(detail: DetailBase) {
        this.detailPageObjectModel = detail;
    }

    async canAddNewEntity(t: TestController): Promise<void> {
        await this.detailPageObjectModel.populateForm(t, generateString(10)); // Deferred to subclasses
        await t
            .expect(this.detailPageObjectModel.getSaveSelector().exists).ok()
            .click(this.detailPageObjectModel.getSaveSelector());
        await t.expect(this.detailPageObjectModel.getSuccessToastSelector().exists).ok();
    }
}