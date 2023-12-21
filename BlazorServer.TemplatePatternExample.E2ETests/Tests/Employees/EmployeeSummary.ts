import { t } from "testcafe";
import EmployeeSummary from "../../PageObjects/Employees/EmployeeSummary";
import { SummaryBaseTests } from "../../TestHelpers/SummaryBaseTests";
import { TestHelpers } from "../../TestHelpers/TestHelpers";

const Helpers = new TestHelpers();
const BaseTests = new SummaryBaseTests(EmployeeSummary, Helpers);

fixture('Employee Summary Tests')
    .page("./employees");


test('Employee Summary | Can Filter Grid By Name', async (t: TestController) => {
    await BaseTests.canFilterByValueInAnyColumn(t, "Name");
});

test('Employee Summary | Can Filter Grid By Description', async (t: TestController) => {
    await BaseTests.canFilterByValueInAnyColumn(t, "Description");
});

test('Employee Summary | Can Filter Grid By Department', async (t: TestController) => {
    await BaseTests.canFilterByValueInAnyColumn(t, "Department");
});

test('Employee Summary | Can Filter Grid By Manager', async (t: TestController) => {
    await BaseTests.canFilterByValueInAnyColumn(t, "Manager");
});