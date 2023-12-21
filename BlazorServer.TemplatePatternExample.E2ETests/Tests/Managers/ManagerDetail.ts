import { t } from "testcafe";
import ManagerDetail from "../../PageObjects/Managers/ManagerDetail";
import { DetailBaseTests } from "../../TestHelpers/DetailBaseTests";

const BaseTests = new DetailBaseTests(ManagerDetail);

fixture('Employee Summary Tests')
    .page("./managerdetail");

test('Manager Detail | Can Add New manager', async (t: TestController) => {
    await BaseTests.canAddNewEntity(t);
});