// Required modules (React and React Router)
import React from 'react';
import { BrowserRouter, Route, Switch} from 'react-router-dom';

// Custom components
import HomePage from '../components/homepage';
import LoginPage from '../components/login/login-page';

// Error components
import ErrorNotFound from '../components/error/error-notfound';

// Custom modules
import { path } from './path';

const routes = {
    rootPageUrl: path,
    loginPageUrl: `${path}login`
};

// React redux
import { createStore } from 'redux';
import { combineReducers } from 'redux'; // Merging multiple reducers into one
import { Provider } from 'react-redux'; // Connecting redux to react

// import reducers
import CalculatorOperationsReducer from '../reducers/calculator/calculator-operations-reducer';

// Redux thunk
import { applyMiddleware } from 'redux';
import thunk from 'redux-thunk'


// Creating new root reducer from multiple small ones
const rootReducer = combineReducers({
    calculatorOperations: CalculatorOperationsReducer,
});


// Create store based on reducer
const store = createStore(
    
    rootReducer,
    window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__(),
    applyMiddleware(thunk)
);



const createRouteStructure = () => {

    return (
        <Provider store={ store }>
            <div> 
                <BrowserRouter>
                    <div> 
                        <Switch>
                            <Route path={ routes.rootPageUrl } exact component={ HomePage } />
                            <Route path={ routes.loginPageUrl } exact component={ LoginPage } />
                            <Route exact component={ ErrorNotFound } />
                        </Switch>
                    </div>
                </BrowserRouter>
            </div>
        </Provider>
    );
};




export { createRouteStructure, routes };