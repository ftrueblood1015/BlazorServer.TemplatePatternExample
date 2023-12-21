import { Selector, t } from "testcafe";
import { DetailBase } from "../../PageObjects/DetailBase";

export class ManagerDetail extends DetailBase {
    private header: Selector;

    constructor() {
        super();
        this.header = Selector("#header_newmanager");
    }

    public getHeaderSelector(): Selector {
        return this.header;
    }
}

export default new ManagerDetail();