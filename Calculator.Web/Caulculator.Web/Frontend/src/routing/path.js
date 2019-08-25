// Method for getting root of production version or development version
const getRoot = () => {

    const os = require('os');
    let path;

    if(os.hostname().indexOf("local") > -1)
        path = "/";
    else
        path = "/BP/";

    return path;
}

// Path variable to export
const path = getRoot();

export { path }
