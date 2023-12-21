import { Selector, t } from "testcafe";
import { generateString } from "../Utilities"

export class DetailBase {
    private activeSelector: Selector;
    private nameSelector: Selector;
    private descriptionSelector: Selector;
    private departmentSelector: Selector;
    private saveButton: Selector;
    private resetButton: Selector;
    private cancelButton: Selector;
    private successToast: Selector;

    constructor() {
        this.activeSelector = Selector("#checkbox_active");
        this.nameSelector = Selector("#text_name");
        this.descriptionSelector = Selector("#textarea_description");
        this.departmentSelector = Selector("#text_department");
        this.saveButton = Selector("#button_new");
        this.resetButton = Selector("#text_reset");
        this.cancelButton = Selector("#text_cancel");
        this.successToast = Selector("div").withText("Added New");
    }

    public getHeaderSelector(): Selector {
        throw new Error("not Implemented");
    }

    public async populateForm(t: TestController, name: string): Promise<void> {
        await t
            .expect(this.activeSelector.exists).ok()
            .expect(this.nameSelector.exists).ok()
            .expect(this.descriptionSelector.exists).ok()
            .expect(this.departmentSelector.exists).ok();

        await t
            .typeText(this.nameSelector, name)
            .typeText(this.departmentSelector, generateString(8))
            .typeText(this.descriptionSelector, generateString(8))
            .click(this.activeSelector);
    }

    public getActiveSelector(): Selector {
        return this.activeSelector;
    }

    public getNameSelector(): Selector {
        return this.nameSelector;
    }

    public getDescriptionSelector(): Selector {
        return this.descriptionSelector;
    }

    public getDepartmentSelector(): Selector {
        return this.departmentSelector;
    }

    public getSaveSelector(): Selector {
        return this.saveButton;
    }

    public getResetSelector(): Selector {
        return this.resetButton;
    }

    public getCancelSelector(): Selector {
        return this.cancelButton;
    }

    public getSuccessToastSelector(): Selector {
        return this.successToast;
    }
}