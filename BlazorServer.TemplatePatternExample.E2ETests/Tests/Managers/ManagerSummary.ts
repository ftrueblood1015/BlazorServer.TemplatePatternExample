import { t } from "testcafe";
import ManagerSummary from "../../PageObjects/Managers/ManagerSummary";
import { SummaryBaseTests } from "../../TestHelpers/SummaryBaseTests";
import { TestHelpers } from "../../TestHelpers/TestHelpers";

const Helpers = new TestHelpers();
const BaseTests = new SummaryBaseTests(ManagerSummary, Helpers);

fixture('Manager Summary Tests')
    .page("./managers");

test('Manager Summary | Can Filter Grid By Name', async (t: TestController) => {
    await BaseTests.canFilterByValueInAnyColumn(t, "Name");
});

test('Manager Summary | Can Filter Grid By Description', async (t: TestController) => {
    await BaseTests.canFilterByValueInAnyColumn(t, "Description");
});

test('Manager Summary | Can Filter Grid By Department', async (t: TestController) => {
    await BaseTests.canFilterByValueInAnyColumn(t, "Department");
});