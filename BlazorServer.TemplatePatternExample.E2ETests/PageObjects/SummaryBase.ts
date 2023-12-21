import { Selector, t } from "testcafe";

export class SummaryBase {
    private SearchBar: Selector;
    private AddButton: Selector;
    private DeleteButton: Selector;
    private EditButton: Selector;

    constructor() {
        this.SearchBar = Selector("#text_search");
        this.AddButton = Selector("#button_new");
        this.DeleteButton = Selector("#button_delete");
        this.EditButton = Selector("#button_edit");
    }

    public getHeaderSelector(): Selector {
        throw new Error("not Implemented");
    }

    public getDataGridSelector(): Selector {
        throw new Error("not Implemented");
    }

    public getDataGridColumns(): string[] {
        throw new Error("not Implemented");
    }

    public getSearchBarSelector(): Selector {
        return this.SearchBar;
    }

    public getAddButtonSelector(): Selector {
        return this.AddButton;
    }

    public getEditButtonSelector(): Selector {
        return this.EditButton;
    }

    public getDeleteButtonSelector(): Selector {
        return this.DeleteButton;
    }
}