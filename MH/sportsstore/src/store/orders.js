import Axios from "axios";

const ORDER_URL = "http://localhost:3500/orders";
export default {
    actions: {
        async storeOrder(context, order) {
            order.cartLines = context.rootState.cart.lines;
            return (await Axios.post(ORDER_URL, order)).data.id;
        }
    }
}