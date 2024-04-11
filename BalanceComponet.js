//// BalanceComponent.js
//import React, { useState, useEffect } from 'react';
//import BalanceService from './BalanceService';
//import { Pie } from 'react-chartjs-2';

//const BalanceComponent = () => {
//    const [balanceData, setBalanceData] = useState(null);

//    useEffect(() => {
//        const fetchBalanceData = async () => {
//            try {
//                const data = await axios.get('/api/FinancialAnalysis/current');;
//                setBalanceData(data);
//            } catch (error) {
//                console.error('Error fetching balance data:', error);
//            }
//        };

//        fetchBalanceData();
//    }, []);

//    return (
//        <div>
//            {balanceData && (
//                <div>
//                    <h2>Balance for Current Month</h2>
//                    <p>Total Income: {balanceData.income}</p>
//                    <p>Total Expenses: {balanceData.moneySpent}</p>
//                    <p>Total Savings: {balanceData.savings}</p>
//                    <Pie
//                        data={{
//                            labels: ['Total Income', 'Total Expenses'],
//                            datasets: [
//                                {
//                                    label: 'Balance',
//                                    data: [balanceData.income, balanceData.moneySpent],
//                                    backgroundColor: ['#36A2EB', '#FF6384'],
//                                },
//                            ],
//                        }}
//                    />
//                </div>
//            )}
//        </div>
//    );
//};

//export default BalanceComponent;