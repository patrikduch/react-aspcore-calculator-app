import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import * as calculatorActions from '../../../actions/calculator-action';
import '../../../styles/history.scss';
import ShortId from 'shortid';




class CalculatorHistory extends React.Component {



    render() {


        return (

            <div>



                <div className="container">

                    <p className="history-title">Historie</p>

                    <div className="row">


                        {this.props.history.map(arg =>

                            <div className="col-sm-4" key={ShortId.generate()}>

                                Id:{arg.id}, Výraz: {arg.expression}, Výsledek: {arg.result}

                            </div>
                        )}

                        {

                            this.props.history.length === 0 && <div>Historie je prázdná </div>

                        }

                    </div>

                </div>

            </div>
        )

    }


}


function mapStateToProps(state, ownProps) {
    return {
        inputEntry: state.calculatorOperations.inputEntry,
        history: state.calculatorOperations.history

    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: bindActionCreators(calculatorActions, dispatch)
    };
}

export default connect(mapStateToProps, mapDispatchToProps)(CalculatorHistory);
