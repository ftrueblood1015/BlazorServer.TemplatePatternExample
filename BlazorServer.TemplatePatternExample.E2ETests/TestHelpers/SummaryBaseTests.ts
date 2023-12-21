import { SummaryBase } from "../PageObjects/SummaryBase";
import { TestHelpers } from "./TestHelpers";

export class SummaryBaseTests {

    private testHelpers: TestHelpers;
    private summaryPageObjectModel: SummaryBase;
    constructor(summary: SummaryBase, helpers: TestHelpers) {
        this.testHelpers = helpers;
        this.summaryPageObjectModel = summary;
    }

    async canFilterByValueInAnyColumn(t: TestController, column: string): Promise<void> {
        // Arrange
        const dataGrid = this.summaryPageObjectModel.getDataGridSelector(); // deferred to a SummaryBase sub class
        const searchInput = this.summaryPageObjectModel.getSearchBarSelector();

        // Act: use search bar to type value
        const value = await this.testHelpers.getFirstNonNullOrEmptyValue(t, dataGrid, column);
        await t
            .expect(searchInput.exists).ok()
            .typeText(searchInput, value);

        const rows = dataGrid.find('tbody > tr'); // get all rows in table
        const rowCount = await rows.count; // wait on the count

        // Assert: Our value should be in any td in a row
        for (let i = 0; i < rowCount; i++) {
            const currentRow = rows.nth(i);
            const tds = currentRow.find('td');
            const tdCount = await tds.count;
            let allInnerText = '';
            for (let j = 0; j < tdCount; j++) {
                allInnerText += await tds.nth(j).innerText; // concat all td's inner text in current row
            }
            await t.expect(allInnerText).contains(value); // our value should be in all the inner text
        }
    }
}