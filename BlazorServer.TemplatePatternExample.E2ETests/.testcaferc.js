module.exports = {
    "src": "Tests",
    "browsers": ["chrome"], // Browsers
    "baseUrl": "https://localhost:7204/", // URL
    "skipJsErrors": true, // Ignores JavaScript errors
    "selectorTimeout": 30000,
    "assertionTimeout": 30000,
    "ajaxRequestTimeout": 30000,
    "pageLoadTimeout": 30000,
    "browserInitTimeout": 120000,
    "speed": 0.5,
    "disablePageCaching": true,
    "quarantineMode": {
        "successThreshold": 1,
        "attemptLimit": 3
    }
}