%% load model and data
clear;
clc;
load('D:\Derek\Software\temp\WinformNNTrainer\ApplyKerasModel_Matlab\testdata\data.mat');

%% apply net
test_data = data(:,1:5);
% test_data = test_data + 1;
test_results = zeros(size(test_data,1),1);
for i = 1:size(test_data,1)
    [test_results(i)] = applyKerasTrainedModel(test_data(i,:),weights,[10 10]);
end
expected_results = data(:,end);
figure;
plot(test_results,'bx'); hold on;
plot(expected_results,'r.');
legend('test results','expected results');
grid on;