%% Clear
clear all
close all
clc

%% Input and display the binary image
I0 = imread('onion.png');
row = size(I0,1);
column=size(I0,2);
I=rgb2gray(I0);
I=double(I);

%% Blur the image, corrupt the image using WGN and display it
% h is the blurring kernel, and sigma is the noise standard deviation
h = ones(4,4)/16;

sigma = 10;
Xf = fft2(I);
Hf = fft2(h,row,column);

y = real(ifft2(Hf.*Xf))+sigma*randn(row,column); % circular convolution 
%% Restoration using generalized Wiener filtering
ewx = WienerFilter_fft(y,h,sigma);
PSNR = abs([psnr(I,I) psnr(y,I) psnr(ewx,I)]) %peak to noise ratio
MSE = [immse(I,I) immse(y,I) immse(ewx,I)] %Mean squared error
subplot(221)
imshow(I0)
title('RGB Image')
subplot(222)
imshow(I,gray(256))
title('Gray Image')
subplot(223)
imshow(y,gray(256))
title('Noise and blur Image')
subplot(224)
imshow(ewx,gray(256))
title('Restored Image')
close all
%% Test with different sigma
sigma1 = 10;
sigma2 = 20;
sigma3 = 30;
sigma4 = 40;

y1 = real(ifft2(Hf.*Xf))+sigma1*randn(row,column); % circular convolution 
y2 = real(ifft2(Hf.*Xf))+sigma2*randn(row,column);
y3 = real(ifft2(Hf.*Xf))+sigma3*randn(row,column);
y4 = real(ifft2(Hf.*Xf))+sigma4*randn(row,column);

ewx1 = WienerFilter_fft(y1,h,sigma1);
ewx2 = WienerFilter_fft(y2,h,sigma2);
ewx3 = WienerFilter_fft(y3,h,sigma3);
ewx4 = WienerFilter_fft(y4,h,sigma4);
subplot(241)
imshow(y1,gray(256))
title('Noise Image sigma=10')

subplot(242)
imshow(y2,gray(256))
title('Noise Image sigma=20')

subplot(243)
imshow(y3,gray(256))
title('Noise Image sigma=30')

subplot(244)
imshow(y4,gray(256))
title('Noise Image sigma=40')

subplot(245)
imshow(ewx1,gray(256))
title('Restored Image sigma=10')

subplot(246)
imshow(ewx2,gray(256))
title('Restored Image sigma=20')

subplot(247)
imshow(ewx3,gray(256))
title('Restored Image sigma=30')

subplot(248)
imshow(ewx4,gray(256))
title('Restored Image sigma=40')
return
