function out = dft2(x)
        y = zeros(size(x));
        y1 = y;
        C = size(x,2); %number of columns
        for c = 1:C
            y(:,c) = dft(x(:,c));
        end
        R = size(x,1); %number of rows
        for r = 1:R
            y1(r,:) = dft(y(r,:).');
        end
        out = y1;
end