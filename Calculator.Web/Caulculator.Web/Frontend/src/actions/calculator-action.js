import * as types from './action-types';
// Api calling
import CalculatorApi from '../api/calculator-api';


export function appendCharacter(character) {
  return {
    type: types.APPEND_CHAR,
    char: character
  };
}

export function calculate(expression) {
  return {
    type: types.EVAULATE_EXPRESSION,
    expr: expression
  };
}


//export function getHistory() {
//
//
//  return (dispatch) => {

//    (sendGet("http://localhost:17716/Calculator/GetHistory").then((ret) => {
//      dispatch({
//        type: types.GET_HISTORY,
//        data: ret.data

//      })
//    }))
//  }
//}


export function getHistory() {


  return (dispatch) => {

    CalculatorApi.getCalculations().then((ret) => {

      dispatch({
        type: types.GET_HISTORY,
        data: ret.data
      })

    }).catch(error => {

      dispatch({
        type: types.GET_HISTORY_FAILURE,
        data: error
      })

    })


  }




}


export function addNew(data, cb) {

  return (dispatch) => {

    //const request = axios.post("http://localhost:17716/Calculator/New/",data)
    const request = CalculatorApi.postNewCalculations(data).then((ret) => {

      dispatch({
        type: types.EVAULATE_EXPRESSION_SUCCESS,
        data: ret.data
      })


    }).catch(error => {

      dispatch({
        type: types.EVAULATE_EXPRESSION_FAILURE,
        data: error
      })
    })


      .then(

        () => cb() // Call callback from passed argument

      )
  }
}
