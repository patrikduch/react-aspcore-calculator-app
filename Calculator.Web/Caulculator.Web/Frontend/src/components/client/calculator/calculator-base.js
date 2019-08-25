import React from 'react';

import CalculatorButtons from '../calculator/calculator-buttons';
import CalculatorHistory from './calculator-history';

class Calculator extends React.Component {


    render() {
        return (
            <div> 
                <CalculatorButtons />
                <CalculatorHistory />
            </div>
        )
    }
}


export default Calculator;