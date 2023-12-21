import { t } from "testcafe";
import EmployeeDetail from "../../PageObjects/Employees/EmployeeDetail";
import { DetailBaseTests } from "../../TestHelpers/DetailBaseTests";

const BaseTests = new DetailBaseTests(EmployeeDetail);

fixture('Employee Summary Tests')
    .page("./employeedetail");

test('Employee Detail | Can Add New Employee', async (t: TestController) => {
    await BaseTests.canAddNewEntity(t);
});