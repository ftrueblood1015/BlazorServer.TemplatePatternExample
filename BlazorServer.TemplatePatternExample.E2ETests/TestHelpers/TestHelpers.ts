import { t, Selector } from "testcafe";

export class TestHelpers {

    async selectFromDropDown(t: TestController, dropDown: Selector, optionNumber?: number) {
        const optionsList = Selector('.mud-list');
        let option = 0;
        if (optionNumber) {
            option = optionNumber;
        }
        await t
            .expect(dropDown.exists).ok()
            .click(dropDown)
            .expect(optionsList.exists).ok()
            .click(optionsList.find('p').nth(option))
            .expect(dropDown.value).ok();
    }

    async getFirstNonNullOrEmptyValue(t: TestController, dataGrid: Selector, columnName: string) {
        let result = '';

        const rows = dataGrid.find('tbody > tr');
        const count = await rows.count; // get number of rows

        // loop through until we get a valid value
        for (let i = 0; i < count; i++) {
            const tdText = await dataGrid.find('td').withAttribute('data-label', columnName).nth(i).innerText;
            if (tdText && tdText !== '') {
                return tdText
            }
        }
        return result
    }
}